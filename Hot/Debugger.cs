namespace hot
{
    using System.Reflection;
    using System.Collections;

    static class Debugger
    {
        public static int vsWaitTimeoutTime = 30; // 等待vs连接的时间，超过此时间，则不等待
        public static int port = 56000; // 端口号
    }
}