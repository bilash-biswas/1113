package main

import (
	"fmt"
)

func main() {
	var a, b int
bilash:
	fmt.Scan(&a)
	fmt.Scan(&b)
	for a != b {
		if a > b {
			fmt.Printf("Decrescente\n")
		}
		if a < b {
			fmt.Printf("Crescente\n")
		}
		goto bilash
	}

}
