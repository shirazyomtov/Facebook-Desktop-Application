using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWinFormsAppLogic
{
    public interface IMatchStrategy
    {
        bool CouldBeMatch(FriendLogic i_Friend);
    }
}
