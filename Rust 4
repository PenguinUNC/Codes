use std::io::{self, Write};
fn main()
{
    let mut input = String::new();
    print!("Your age: ");
    io::stdout().flush().unwrap();
    io::stdin().read_line(&mut input).unwrap();
    let age: i32 = input.trim().parse().unwrap();
    if age > 18
    {
        print!("Adult");
    }
    else if age == 18
    {
        print!("Have reached adulthood");
    }
    else
    {
        print!("Minor");
    }
}
