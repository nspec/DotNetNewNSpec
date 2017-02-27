using NSpec;
using System;

namespace CSharp.TestLibrary
{
    public class describe_sample : nspec
    {
        void before_each()
        {
        }

        void after_each()
        {
        }

        void it_passes()
        {
            true.ShouldBeTrue();
        }

        void some_scenario()
        {
            before = () => { };

            act = () => { };

            context["some sub-scenario"] = () =>
            {
                before = () => { };

                it["passes"] = () => true.ShouldBeTrue();

                it["passes by throwing"] = () => expect<DivideByZeroException>(() => { throw new DivideByZeroException(); });
            };
        }
    }
}
