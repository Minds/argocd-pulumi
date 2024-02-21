package shim

import (
	"github.com/hashicorp/terraform-plugin-sdk/v2/helper/schema"
	"github.com/oboukili/terraform-provider-argocd/argocd"
)

func NewProvider() *schema.Provider {
	return argocd.Provider()
}