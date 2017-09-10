<?php

$handle = fopen ("php://stdin", "r");
function solve($n, $s, $d, $m){
    $piecesNumber = 0;
    for ($i = 0; $i < $n; $i++) {
        $sum = 0;
        for ($j = 0; $j < $m; $j++) {
            if ($j + $i >= $n) {
                break;
            } else {
                $sum += $s[$i + $j];
            }
        }
        if ($sum == $d) {
            $piecesNumber++;
        }
    }
    return $piecesNumber;
}

fscanf($handle, "%d",$n);
$s_temp = fgets($handle);
$s = explode(" ",$s_temp);
$s = array_map('intval', $s);
fscanf($handle, "%d %d", $d, $m);
$result = solve($n, $s, $d, $m);
echo $result . "\n";

?>