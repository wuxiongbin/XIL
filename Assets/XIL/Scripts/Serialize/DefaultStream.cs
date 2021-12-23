namespace wxb
{
    public class DefaultStream : WRStream, IStream
    {
        public DefaultStream(int size) : base(size)
        {

        }

        public DefaultStream(byte[] bytes) : base(bytes)
        {

        }

        public void WriteUnityObject(UnityEngine.Object obj)
        {
            throw new System.Exception("WriteUnityObject");
        }

        public UnityEngine.Object ReadUnityObject()
        {
            throw new System.Exception("ReadUnityObject");
        }
    }
}