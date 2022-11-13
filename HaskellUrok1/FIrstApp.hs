maxNum :: Ord a => [a] -> a
maxNum [x] = x
maxNum (x:x':xs) = maxNum ((if x >= x' then x else x'):xs)

main :: IO() --main function
main = do 
    input <- getLine
    let n = words input
    let intn = map (read::String->Int) n 
    print(maxNum intn)