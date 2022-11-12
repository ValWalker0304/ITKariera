string1 = "Hello World!" --string varianble (name --> string1)

doubleIt x = x * 2  --int variable (name --> doubleIt)

main :: IO() --main function
main = do 
    print(doubleIt 5)
    print(string1)