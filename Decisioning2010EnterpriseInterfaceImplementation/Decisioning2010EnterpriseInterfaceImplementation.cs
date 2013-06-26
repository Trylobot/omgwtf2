

using System;
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
            var converted_output = System.Convert.ToUInt64( decision.getFinalDecision() );
            if( converted_output % 2 == 0/*if the converted output  even*/ )
            {
                /* then perform the following logic */
                decision = impl.MkDecisionObj( (impl.read_CONFIG_file_reader_func())() );
                converted_output = System.Convert.ToUInt64( 
                    decision.getFinal_Decision_EX( 
                        (decimal)(impl.read_CONFIG_file_reader_func())()
                            .get_UNIVERSAL_DECISION_WEIGHT() ) );
                
                decision.cleanup();
                try{decision.postCleanup_garbgagecollection();}catch(Exception){}
            }
            Debugger.Log(0,"",( converted_output % 2 == 0 )? "0\n" : "1\n" );
            System.Console.WriteLine(( converted_output % 2 == 0 )? "0" : "1" );
        }

        public I_FinalDecisionRepresentation MkDecisionObj( IStaticCompanyPreferencesAndValuesConfiguration confg )
        {
            if( confg != null )
                return new decidsion( 0 );
            else
                return new decidsion( -65536/*not sure why this works*/ );
        }

        public Func<IStaticCompanyPreferencesAndValuesConfiguration> read_CONFIG_file_reader_func()
        {
            // more dynamicism and decoupling
            return new Func<IStaticCompanyPreferencesAndValuesConfiguration>(
                () => new IStaticCompanyPreferencesAndValuesConfiguration());
        }
    }
}
