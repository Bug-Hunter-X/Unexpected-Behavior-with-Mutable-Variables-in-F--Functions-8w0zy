let x = ref 10
let y = ref 20

let add x y = !x + !y

let z = add x y
printf "%d" z

 x := 100
y := 200

printf "%d %d %d" !x !y z