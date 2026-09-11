namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1: Struct vs Class Copy Behavior

            /*
             * QUESTION 1:
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

            #region Question 2: Encapsulation and Design Improvements

            /*
             * QUESTION 2:
             * a) Three problems with this design:
             *    1. Public Fields: Fields are declared as 'public', giving external code direct access to change them 
             *       without any control or restriction.
             *    2. Lack of Data Validation: There are no boundary checks, meaning invalid data can easily be assigned 
             *       (e.g., Weight = -15 or DeliveryFee = -500).
             *    3. Risk of Null/Empty Data: Fields like 'Description' can be set to null or empty whitespace strings, 
             *       leading to an inconsistent state for the object.
             * 
             * b) How Private Fields & Public Properties improve this design:
             *    1. Data Hiding (Private Fields): By changing fields to 'private', we hide the internal state of the 
             *       object and block direct external access.
             *    2. Controlled Access & Validation (Public Properties): Public properties act as gateways. Inside their 
             *       'set' accessors, we can add validation logic to inspect incoming values before updating the field.
             *    3. State Preservation: If an invalid value is assigned, the property setter can reject it and keep 
             *       the previous valid state intact.
             */

            #endregion
        }
    }
}
