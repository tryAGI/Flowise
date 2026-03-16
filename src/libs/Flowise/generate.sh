dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/FlowiseAI/Flowise/refs/heads/main/packages/api-documentation/src/yml/swagger.yml
if ! grep -q '^openapi:' openapi.yaml; then
  tmp_openapi="$(mktemp)"
  {
    cat <<'YAML'
openapi: 3.0.1
info:
  title: Flowise API
  version: 1.0.0
  description: This is the API documentation for the Flowise service.

YAML
    cat openapi.yaml
  } > "$tmp_openapi"
  mv "$tmp_openapi" openapi.yaml
fi

autosdk generate openapi.yaml \
  --namespace Flowise \
  --clientClassName FlowiseClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations
