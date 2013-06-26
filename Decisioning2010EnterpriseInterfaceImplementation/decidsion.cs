using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace biz_impl
{
    class decidsion : I_FinalDecisionRepresentation
    {
        private int FMT_MODE___ {set;get;}
        
        public decidsion( int formatting_mode )
        {
            this.FMT_MODE___ = formatting_mode;
        }

        public string getFinalDecision()
        {
            var input = DateTime.Now.ToString();
            var value = бизнес_сфере.машина.вычисления_хэш( input );
            return value.ToString();
        }

        public string getFinal_Decision_EX(decimal weight)
        {
            var decis = getFinalDecision();
            Int32 decis_value;
            try {
                decis_value = Convert.ToInt32( decis );
            }catch(Exception){
                decis_value = 0;
            }
            decis_value = (Int32)((decimal)decis_value * weight);
            return (string)decis_value.ToString(new Decisioning2010EnterpriseInterfaceImplementation.EnterpriseStandardFormatter());
        }

        public void cleanup()
        {
            if( FMT_MODE___ == 0 ) {
                Debugger.Log( 5, "IMPORTANT", "*** ==== **** CLEANUP HAS OCCURRED: CLEANUP NOT NECESSARY FOR THIS TYPE ___\n");
                System.Console.WriteLine( "*** ==== **** CLEANUP HAS OCCURRED: CLEANUP NOT NECESSARY FOR THIS TYPE ___" );
            }

        }

        public void postCleanup_garbgagecollection()
        {
            throw new NotImplementedException();
        }
    }
}
