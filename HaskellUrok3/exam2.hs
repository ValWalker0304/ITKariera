--printStar str n =
    --if n == 0
    --    then decNumber n
  --      else str ++ (printStar str (n-1))
--decNumber a =
   -- if a == 0
   --     then ""
  --      else printStar (a-1)

--main :: IO()
--main = do
  --  input <- getLine
   -- let n = read input :: Char
   -- print(printStar "*" n)



printTriangle 0 = return ()
printTriangle n = 
    do
        putStrLn (asterixStringRow n)
        printTriangle (n - 1)

asterixStringRow n = replicate n '*'

main = do
    input<- getLine 
    let n= read input :: Int
    printTriangle n