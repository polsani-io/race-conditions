package main

import "fmt"

var counter = 0

func main() {
	incrementCounter()

	fmt.Printf("The final value of counter is: %d\n", counter)
}

func incrementCounter() {
	for i := 0; i < 1000000; i++ {
		counter++
	}
}
