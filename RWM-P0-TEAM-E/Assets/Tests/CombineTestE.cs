using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{

        public class CombinedFilterTest
        {
            [Test]
            public void CombinedFilterSimple()
            {
                //Assert.IsTrue(false);

                int[] input = { 1, 3, 5, 7, 9 };
            //Xor21  
            //Mod3 
            //Running Totals 
            int[] output = CombinedFilter.combinedFilter(input);
                int[] expected = { 100, 000, 200, 100, 0 };


                CollectionAssert.AreEqual(output, output);
            }
        }

    
    
}
