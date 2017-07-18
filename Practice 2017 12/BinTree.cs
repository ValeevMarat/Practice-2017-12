namespace Practice_2017_12
{
    class BinTree
    {
        public int Data;      // Информационное поле
        public BinTree Left;  // Ссылка на левую ветку
        public BinTree Right; // Ссылка на правую ветку

        public BinTree(int d)
        {
            Data = d;
            Left = null;
            Right = null;
        }
    } // Класс бинарного дерева
}
