set -e
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -o openapi.yaml https://raw.githubusercontent.com/FlowiseAI/Flowise/refs/heads/main/packages/api-documentation/src/yml/swagger.yml

autosdk generate openapi.yaml \
  --namespace Flowise \
  --clientClassName FlowiseClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations
