# F# Mutable Variable Swap Bug

This repository demonstrates a subtle bug related to mutable variables and function calls in F#.

## The Bug
The `swap` function attempts to swap the values of two mutable variables. While it appears to work correctly, there's an important nuance related to how mutable variables are handled within function scopes. 

## Reproducing the Bug
1. Clone this repository.
2. Open `bug.fs` in an F# editor (e.g., Visual Studio, VS Code with Ionide).
3. Compile and run the code. Observe that the values aren't swapped as expected when using the `swap` function, but they are swapped correctly with `swap2` function.

## Solution
The solution involves understanding how F# handles mutable variables. Inside a function, assignment operations modify the variables' values only within that function's scope. In other words, when `swap` function modifies the values of x and y, it only changes the variables inside `swap` and not the original values of x and y.
The `swap2` function returns a tuple containing the swapped values. To ensure the swap is reflected outside the function, you should return the swapped values as a tuple and assign the values returned by `swap2` to different variables.