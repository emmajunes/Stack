namespace Stack
{
    internal partial class Program
    {
        public class Stack
        {
            public List<object> list = new List<object>();

            public void Push(object obj)
            {
                if (obj == null)
                {
                    throw new InvalidOperationException("Input can not be null!");
                }
                else
                {
                    list.Add(obj);
                }
                    
            }

       
            public object Pop()
            {
                if(list.Count == 0)
                {
                    throw new InvalidOperationException("List is empty!");
                }

                var index = list.Count - 1; 
                var item = list[index]; 
                list.RemoveAt(index);
                return item;

            }

            public void Clear()
            {
                list.Clear();

               
            }

        }
    }
}