import Control.Monad
check n 
    | n == "1" = "one"
    | n == "2" = "two"
    | n == "3" = "three"
    | n == "4" = "four"
    | n == "5" = "five"
    | n == "6" = "six"
    | n == "7" = "seven"
    | n == "8" = "eight"
    | n == "9" = "nine"
    | otherwise = "not valid number"


main :: IO()
main = do
    n<-getLine 
    unless (n == "End" ) $ do
    putStrLn (check n)
 
    main
    