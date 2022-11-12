string = "Hello World!" 

doubleIt x = x * 2

main :: IO()
main = do 
    print(doubleIt 5)
    print(string)