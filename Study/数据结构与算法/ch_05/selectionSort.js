function selectionSort(array) {
  for (var i = 0; i < array.length; i++) {
    var lowestNumberIndex = i;
    for (var j = i + 1; j < array.klength; j++) {
      if (array[j] < array[lowestNumberIndex]) {
        lowestNumberIndex = j;
      }
    }
    if (lowestNumberIndex != i) {
      var temp = array[i];
      array[i] = array[lowestNumberIndex];
      array[lowestNumberIndex] = temp;
    }
  }
  return array;
}