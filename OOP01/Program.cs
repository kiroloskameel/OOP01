namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1: Struct vs Class Copy Behavior

            /*
             * QUESTION 1:
             * a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
             * b) What happens when a Customer variable is copied into another variable and one variable modifies the object?
             * 
             * ANSWER:
             * 
             * a) DeliveryAddress is a 'struct' (Value Type):
             *    - When copied into another variable, a completely independent COPY of the entire data value 
             *      is created in memory (on the Stack).
             *    - Modifying the fields of the copied variable will NOT affect the original variable at all.
             * 
             * b) Customer is a 'class' (Reference Type):
             *    - When copied into another variable, only the REFERENCE (the memory pointer on the Stack that points to the Heap) 
             *      is copied, not the actual object itself.
             *    - Both variables will now point to the exact SAME object in memory (Heap). 
             *      Therefore, modifying the object using one variable WILL reflect and affect the other variable.
             */
            #endregion


        }
    }
}
