--compose f g x = f(g x)
--pass3 f = f 3
--add1 x = x + 1
--mult2  x = x * 2 

repeatString str n = 
    if n == 0
        then ""
        else str ++ (repeatString str (n-1))

repeatStringLoop string result n = 
    if n == 0
        then result 
        else repeatStringLoop string (result ++ string) (n -1)      
main :: IO()
main = do
    
    print(repeatString "niz" 10000000000)