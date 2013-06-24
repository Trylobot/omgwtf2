

using System.Diagnostics;
using biz_impl;

namespace BusinessNamespace
{
    class Decisioning2010EnterpriseInterfaceImplementation : IDecidering2009Interface
    {
        static void Main( string[] args )
        {
            var impl = new Decisioning2010EnterpriseInterfaceImplementation();
            var decision = impl.MkDecisionObj( null );

            Debugger.Log(0,"",( System.Convert.ToUInt64( decision.getFinalDecision() ) % 2 == 0 )? "0\n" : "1\n" );
            System.Console.WriteLine(( System.Convert.ToUInt64( decision.getFinalDecision() ) % 2 == 0 )? "0" : "1" );
        }

        public I_FinalDecisionRepresentation MkDecisionObj( IStaticCompanyPreferencesAndValuesConfiguration confg )
        {
            return new decidsion();
        }
    }
}
