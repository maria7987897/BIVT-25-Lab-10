namespace Lab9.White
{
    public abstract class White //только наследоваться
    {
        public string Input { get; private set; } //хранилище входного текста
        //читать везде, менять только внутри класса White
    
        protected White(string input) //конструктор принимает строку и сохр в Input, protected выз ток из наследников
        {
            Input = input;
        } 
        public abstract void Review(); //каждый наследник обязан реализовать
    
        public virtual void ChangeText(string text) //заменить текст и обновить
        {
            Input = text;
            Review();
        }
    }
}
