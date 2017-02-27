using NSpec;
using System.IO;

namespace CSharp.TestLibrary
{
    public class describe_sample : nspec
    {
        StringWriter writer;

        int number = 0;
        string actual = null;
        string expected = null;

        void before_each()
        {
            writer = new StringWriter();
        }

        void after_each()
        {
            writer.Dispose();
        }

        void converting_to_message()
        {
            act = () =>
            {
                writer.Write("Number is: ");
                writer.Write(number);

                actual = writer.ToString();
            };

            context["when number is positive"] = () =>
            {
                before = () =>
                {
                    number = 123;
                    expected = "Number is: 123";
                };

                it["returns correct message"] = () => (actual == expected).ShouldBeTrue();
            };

            context["when number is negative"] = () =>
            {
                before = () =>
                {
                    number = -456;
                    expected = "Number is: -456";
                };

                it["returns correct message"] = () => (actual == expected).ShouldBeTrue();
            };
        }
    }
}
