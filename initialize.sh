dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Flowise \
  FlowiseClient \
  https://raw.githubusercontent.com/FlowiseAI/Flowise/refs/heads/main/packages/api-documentation/src/yml/swagger.yml \
  tryAGI \
  --output .
