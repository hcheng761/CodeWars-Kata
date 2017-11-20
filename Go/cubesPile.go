package kata

func FindNb(m int) int {
  // your code
  var total int = 0
  var i int = 0
  for total<m {
      total += i*i*i
      i++
  }

  if total==m {
      return i-1
    } else {
      return -1
    }
}
