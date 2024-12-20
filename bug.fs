let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 10

let swap2 x y = 
    let temp = x
    x <- y
    y <- temp
    (x,y) //Tuple

let a,b = swap2 x y
printf "%d %d" a b //This will print 20 10