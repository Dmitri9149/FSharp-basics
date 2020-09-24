module Strings = 

    let string1 = "Hello"
    let string2 = "world"

    // verbatim string

    let string3 = @"C:\Program Files\   my .... crasy foldername \\\\"

    // triple quotes 

    let string4 = """Say "hello world" to world """

    // string concatenation 

    let helloWorld = string1 + " " + string2 + "\n"

    printf "%s" helloWorld


    // take first 7 (not 6 !!) characters
    let substring = helloWorld.[0..6]

    printf "%s" (substring + "     first 7 characters of var helloWorld 
    i.e. 'Hello world'\n")
