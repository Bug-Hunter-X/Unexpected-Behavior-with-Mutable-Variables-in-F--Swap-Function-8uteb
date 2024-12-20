let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp
    (x,y)

let a,b = swap x y
printf "%d %d" a b //This will print 20 10

//Alternative solution using a more functional approach (avoiding mutability)
let swapFunctional x y = (y, x)

let a,b = swapFunctional x y
printf "%d %d" a b //This will print 20 10