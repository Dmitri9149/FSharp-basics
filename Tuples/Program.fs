module Tuples = 

    let tuple1 = (1,2,3)

    // polymorphism
    let swapElem (a,b) = (b,a) 

    printf "The result of swapping (1,2) is %A\n" (swapElem(1,2)) 

    
