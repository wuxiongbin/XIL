namespace wxb
{
    public static class TypeFlags
    {
        public const byte classType = 0; // 类型

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
        public const byte enumType = 15; // 枚举类型,整形存储
        public const byte enumStringType = 16; // 枚举类型，字符串存储
        public const byte vector2Int = 17; // Vector2Int
        public const byte vector3Int = 18; // Vector3Int

        public const byte unityObjectType = 20; // unity类型
        public const byte csharpAgentType = 21; // unity代理类型

        public const byte arrayType = 100; // 数组标识
        public const byte dicType = 101; // map类型,key-value键值对
        public const byte smartType = 200; // 智能类型
        public const byte anyRefType = 201; // RefType任意类型
        public const byte objectType = 202; // object任意类型
    }
}