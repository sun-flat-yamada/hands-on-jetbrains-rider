namespace HandsOn
{
    public class HandsOnSample
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static void Main(string[] args)
        {
            System.Console.Out.WriteLine("Hello");
            System.Console.Out.WriteLine("args = {0}", args);
            System.Diagnostics.Debug.Assert(args[ 0 ] != null, "Not Supported: args");
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
