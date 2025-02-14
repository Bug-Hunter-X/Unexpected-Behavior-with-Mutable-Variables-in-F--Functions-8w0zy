# F# Mutable Variable Behavior in Functions

This example demonstrates a potential issue with mutable variables in F#. When a function uses mutable variables, and those variables are modified *after* the function is called, the function's output does not reflect the changes.

The `bug.fs` file shows this problem.  The `bugSolution.fs` file provides a solution.

This behavior can lead to unexpected results if not properly understood.

## How to Reproduce

1. Compile and run `bug.fs`
2. Observe that the output of the `add` function does not reflect the changes made to `x` and `y` after the function is called.