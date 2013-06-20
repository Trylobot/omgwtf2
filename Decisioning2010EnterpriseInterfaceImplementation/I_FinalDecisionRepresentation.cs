using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biz_impl
{
    interface I_FinalDecisionRepresentation
    {
        string getFinalDecision();
        string getFinal_Decision_EX( decimal weight );
        void cleanup();
        void postCleanup_garbgagecollection();
    }
}
