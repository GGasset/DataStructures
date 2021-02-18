namespace DataStructures
{
    public class singlyLinkedList
    {
        ///<summary>Head of the list</summary>
        public ListItem firstItem;

        public singlyLinkedList()
        {
            firstItem = null;
        }

        ///<summary>Adds an element at the end of the list</summary>
        public void AddItem(int value)
        {
            ListItem temporalItem = new ListItem(value);
            ListItem transverser;
            if (firstItem == null)
                firstItem = temporalItem;
            else
            {
                transverser = firstItem;
                while (transverser.nextItem != null)
                    transverser = transverser.nextItem;
                
                transverser.nextItem = temporalItem;
            }
        }

        public override string ToString()
        {
            string output = string.Empty;
            if (firstItem != null)
            {
                output += $"{firstItem.value} | ";
                ListItem transverser = firstItem;
                while (transverser.nextItem != null)
                {
                    transverser = transverser.nextItem;
                    output += $"{transverser.value} | ";
                }
            }
            return output;
        }


        public class ListItem
        {
            public ListItem(int value)
            {
                this.value = value;
                nextItem = null;
            }
            
            public ListItem nextItem;
            public int value;
        }
    }
}