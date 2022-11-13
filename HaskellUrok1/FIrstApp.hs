--maxNum :: Ord a => [a] -> a  "Ordarable"
maxNum [x] = x
maxNum (x:y:z) = maxNum ((if x >= y then x else y):z)

main :: IO() --main function
main = do 
    input <- getLine
    let n = words input
    let intn = map (read::String->Int) n 
    print(maxNum intn)