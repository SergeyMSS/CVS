using System;
using System.Text;

namespace Profiling
{
    class Generator
    {
        public static string GenerateDeclarations()
        {
            StringBuilder str = new StringBuilder();
            foreach (int count in Constants.FieldCounts)
            {
                str.Append(GenerateString("struct S", count));
                str.Append(GenerateString("class C", count));
            }

            return str.ToString();
        }

        public static string GenerateArrayRunner()
        {
            StringBuilder mainStr = new StringBuilder();
            StringBuilder callStr = new StringBuilder();

            mainStr.Append("public class ArrayRunner : IRunner\n{\n");
            callStr.Append("public void Call(bool isClass, int size, int count)\n{\n");

            foreach (int count in Constants.FieldCounts)
            {
                mainStr.Append(GenerateMainContent("C", count));
                mainStr.Append(GenerateMainContent("S", count));

                callStr.Append(GenerateCallContents("C", count));
                callStr.Append(GenerateCallContents("S", count));
            }

            mainStr.Append(callStr);
            mainStr.Append("throw new ArgumentException();\n}\n}");

            return mainStr.ToString();
        }

        public static string GenerateCallRunner()
        {
            throw new NotImplementedException();
        }

        private static string GenerateString(string s, int count)
        {
            StringBuilder str = new StringBuilder();

            str.Append(string.Format("{0}{1}\n{{\n", s, count));

            for (int i = 0; i < count; i++)
            {
                str.Append(string.Format($"byte Value{i};"));
            }

            str.Append("}\n");

            return str.ToString();
        }

        private static string GenerateMainContent(string text, int count)
        {
            StringBuilder str = new StringBuilder();
            str.Append(string.Format(
                "void P{0}{1}()\n{{\nvar array = new {0}{1}[Constants.ArraySize];\n", text, count));

            if (text == "C")
                str.Append(string.Format(
                    "for (int i = 0; i < Constants.ArraySize; i++) array[i] = new C{0}();\n", count));
            str.Append("}\n");
            return str.ToString();
        }

        private static string GenerateCallContents(string text, int count)
        {
            StringBuilder str = new StringBuilder();

            str.Append("if (" + (text == "S" ? "!" : "") + string.Format(
                "isClass && size == {0})\n{{\nfor (int i = 0; i < count; i++) P{1}{0}();\nreturn;\n}}\n", count, text));
            return str.ToString();
        }
    }
}
