

using biz_impl;

namespace BusinessNamespace
{
    class Decisioning2010EnterpriseInterfaceImplementation : IDecidering2009Interface
    {
        static void Main( string[] args )
        {

        }

        public I_FinalDecisionRepresentation MkDecisionObj( IStaticCompanyPreferencesAndValuesConfiguration confg )
        {
            return new decidsion();
        }
    }
}
