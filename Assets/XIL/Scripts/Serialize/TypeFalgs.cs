namespace wxb
{
    public static class TypeFlags
    {
        public const byte intType = 1;
        public const byte uintType = 2;
        public const byte sbyteType = 3;
        public const byte byteType = 4;
        public const byte charType = 5;
        public const byte longType = 6;
        public const byte ulongType = 7;
        public const byte shortType = 8;
        public const byte ushortType = 9;
        public const byte floatType = 10;
        public const byte doubleType = 11;
        public const byte DateTimeType = 12;
        public const byte stringType = 13;
        public const byte boolType = 14;
        public const byte arrayType = 100; // 数组标识
        public const byte unityObjectType = 20; // unity类型

        public const byte classType = 0; // 类型
        public const byte smartType = 200; // 智能类型
    }
}