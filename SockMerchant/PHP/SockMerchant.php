<?php

$handle = fopen ("php://stdin", "r");
function sockMerchant($n, $ar) {
    $pairs = 0;
    for ($i = 0; $i < $n; $i++)
    {
        for ($j = $i+1; $j < $n; $j++)
        {
            if($ar[i] == $ar[j] && $ar[$i]>0)
            {
                $pairs++;
                $ar[i] = -1;
                $ar[j] = -1;
                break;
            }
        }
    }
    return $pairs;
}

fscanf($handle, "%i",$n);
$ar_temp = fgets($handle);
$ar = explode(" ",$ar_temp);
$ar = array_map('intval', $ar);
$result = sockMerchant($n, $ar);
echo $result . "\n";

?>
