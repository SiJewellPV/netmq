﻿using System;

namespace NetMQ.InProcActors
{
    public class ActorKnownMessages
    {
        [Obsolete("Use NetMQActor.EndShimMessage")]
        public const string END_PIPE = "endPipe";
    }
}
