namespace HandsOn
{
    public class HandsOnSample
    {
        /// <summary>
        /// ユニークに特定したい目的があったとする
        /// </summary>
        public static readonly Guid guid = new Guid("483336A7-DFFB-4F9F-9F7E-76DAF0C328D7");
     
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static void Main(string[] args)
        {
            System.Console.Out.WriteLine("Hello");
            System.Diagnostics.Debug.Assert(EXPR != null, "MESSAGE");
            System.Console.Out.WriteLine("args = {0}", args);
        }

        /// <summary>
        /// このコードは良くある断片の例示で内容自体に意味はありません/このコメントはコードしなくて良いです
        /// </summary>
        [System.Serializable]
        public class HandsOnException : System.Exception
        {
            public HandsOnException()
            {
            }

            public HandsOnException(string message) : base(message)
            {
            }

            public HandsOnException(string message, System.Exception inner) : base(message, inner)
            {
            }

            protected HandsOnException(
                System.Runtime.Serialization.SerializationInfo info,
                System.Runtime.Serialization.StreamingContext context) : base(info, context)
            {
            }
        }
    }
}