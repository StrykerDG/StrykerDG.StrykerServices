using System;
using System.Collections.Generic;
using System.Text;

namespace StrykerDG.StrykerServices.TwitchService.Models
{
    public class StrykerTwitchUser
    {
        public TwitchUser User { get; set; }
        public FollowsTo Followers { get; set; }
    }
}
