param(
    [switch]$NoCache,
    [switch]$Run
)

$buildParams = @()

if ($NoCache) {
    $buildParams += @('--no-cache')
}

docker build @buildParams -t codebuilddeploy.azurecr.io/code-build-deploy:latest -f ./CodeBuildDeploy/Dockerfile .

if ($?) {
    if ($Run) {
        & '.\run.ps1'
    }
}
else {
    Write-Warning "Failed to build an upto date image."
}
