checkIndex list n a=
    if a == n 
        then (head list)
        else checkIndex (tail list) n (a+1)

main :: IO()
main = do
    input <- getLine
    let n = words input
    let intList = map (read::String->Int) n
    input2 <- getLine
    let b = read input2 :: Integer
    let a = 0 :: Integer
    print(checkIndex intList b a)