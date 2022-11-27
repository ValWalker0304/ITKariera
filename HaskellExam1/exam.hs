import Data.Char

main :: IO()
main = do
    input <- getLine
    --let converted = countChar 'H' n ::String
    let up = length (filter (isUpper) input) :: Int
    let down = length (filter (isLower) input) :: Int
    let sym = length (filter (isPunctuation) input) + length (filter (isSeparator) input)
    print(down, up, sym)