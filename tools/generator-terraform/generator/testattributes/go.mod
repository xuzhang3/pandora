module github.com/hashicorp/pandora/tools/generator-terraform/testattributes

go 1.18

replace github.com/hashicorp/pandora/tools/sdk => ../../../sdk

require (
	github.com/hashicorp/hcl/v2 v2.13.0
	github.com/hashicorp/pandora/tools/sdk v0.0.0-00010101000000-000000000000
	github.com/zclconf/go-cty v1.10.0
)

require (
	github.com/agext/levenshtein v1.2.1 // indirect
	github.com/apparentlymart/go-textseg/v13 v13.0.0 // indirect
	github.com/google/go-cmp v0.3.1 // indirect
	github.com/mitchellh/go-wordwrap v0.0.0-20150314170334-ad45545899c7 // indirect
	golang.org/x/text v0.3.6 // indirect
)