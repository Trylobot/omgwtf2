using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biz_impl
{
    class decidsion : I_FinalDecisionRepresentation
    {
        public string getFinalDecision()
        {
            var input = DateTime.Now.ToString();
            var value = бизнес_сфере.машина.вычисления_хэш( input );
            return value.ToString();
        }

        public string getFinal_Decision_EX(decimal weight)
        {
            var decis = getFinalDecision();
            var decis_value = Convert.ToInt32( decis );
            decis_value = (Int32)((decimal)decis_value * weight);
            return (string)decis_value.ToString(new Decisioning2010EnterpriseInterfaceImplementation.EnterpriseStandardFormatter());
        }

        public void cleanup()
        {
            ;
        }

        public void postCleanup_garbgagecollection()
        {
            throw new NotImplementedException();
        }
    }
}
