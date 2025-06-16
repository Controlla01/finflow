<?php require_once 'config/connection.php'; ?>

<?php

$loanamount = trim($_POST['loanamount']);
$loanduration = trim($_POST['loanduration']);

// Validation
if ($loanamount === '') {
    $response = [
        'response' => 100,
        'success' => false,
        'message' => "LOAN AMOUNT REQUIRED! Please input loan amount."
    ];
    goto end;
}

if (!is_numeric($loanamount)) {
    $response = [
        'response' => 101,
        'success' => false,
        'message' => "INVALID AMOUNT! Input a valid loan amount."
    ];
    goto end;
}

if ($loanamount < 1000) {
    $response = [
        'response' => 102,
        'success' => false,
        'message' => "AMOUNT TOO LOW! Minimum allowed is NGN1,000."
    ];
    goto end;
}

if ($loanamount > 10000000) {
    $response = [
        'response' => 103,
        'success' => false,
        'message' => "AMOUNT TOO HIGH! Maximum allowed is NGN10,000,000."
    ];
    goto end;
}

if ($loanduration === '') {
    $response = [
        'response' => 104,
        'success' => false,
        'message' => "DURATION REQUIRED! Please input loan duration."
    ];
    goto end;
}

if (!ctype_digit($loanduration)) {
    $response = [
        'response' => 105,
        'success' => false,
        'message' => "INVALID DURATION! Input valid whole number of months."
    ];
    goto end;
}

if ($loanduration < 1) {
    $response = [
        'response' => 106,
        'success' => false,
        'message' => "DURATION TOO SHORT! Minimum is 1 month."
    ];
    goto end;
}

if ($loanduration > 12) {
    $response = [
        'response' => 107,
        'success' => false,
        'message' => "DURATION TOO LONG! Maximum is 12 months."
    ];
    goto end;
}


    $repayment = $loanamount / $loanduration;
    $totalRepayment = 0;
    $totalInterest = 0;
    $data = [];


    for ($month = 1; $month <= $loanduration; $month++) {
        $interest = 0.015 * $loanamount;
        $monthlyRepayment = $repayment + $interest;
        $totalRepayment += $monthlyRepayment;
        $totalInterest += $interest;

        $data[] = [
            'month' => $month,
            'loan_remaining' => round($loanamount, 2),
            'principal_repayment' => round($repayment, 2),
            'interest' => round($interest, 2),
            'monthly_repayment' => round($monthlyRepayment, 2)
        ];

        $loanamount -= $repayment;
    }

        $response = [
            'response' => 200,
            'success' => true,
            'total_interest_paid' => round($totalInterest, 2),
            'total_repayment' => round($totalRepayment, 2),
            'data' => $data
        ];

end:
echo json_encode($response);
?>
