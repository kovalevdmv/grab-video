package main

import (
	"fmt"
	"net/http"
	"path/filepath"
)

func main() {
	fmt.Println("listen port 8080") 
	staticPath, _ := filepath.Abs("")
	fs := http.FileServer(http.Dir(staticPath))
	http.Handle("/", fs)
	http.ListenAndServe(":8080", nil)
}