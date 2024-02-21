// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package argocd

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi-argocd/sdk/go/argocd/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Manages [applications](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#applications) within ArgoCD.
//
// ## Import
//
// ArgoCD applications can be imported using an id consisting of `{name}:{namespace}`. E.g.
//
// ```sh
// $ pulumi import argocd:index/application:Application myapp myapp:argocd
// ```
type Application struct {
	pulumi.CustomResourceState

	// Whether to applying cascading deletion when application is removed.
	Cascade pulumi.BoolPtrOutput `pulumi:"cascade"`
	// Standard Kubernetes object metadata. For more info see the [Kubernetes reference](https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#metadata).
	Metadata ApplicationMetadataOutput `pulumi:"metadata"`
	// The application specification.
	Spec ApplicationSpecOutput `pulumi:"spec"`
	// Status information for the application. **Note**: this is not guaranteed to be up to date immediately after
	// creating/updating an application unless `wait=true`.
	Statuses ApplicationStatusArrayOutput `pulumi:"statuses"`
	// Upon application creation or update, wait for application health/sync status to be healthy/Synced, upon application
	// deletion, wait for application to be removed, when set to true. Wait timeouts are controlled by Terraform Create, Update
	// and Delete resource timeouts (all default to 5 minutes). **Note**: if ArgoCD decides not to sync an application (e.g.
	// because the project to which the application belongs has a `sync_window` applied) then you will experience an expected
	// timeout event if `wait = true`.
	Wait pulumi.BoolPtrOutput `pulumi:"wait"`
}

// NewApplication registers a new resource with the given unique name, arguments, and options.
func NewApplication(ctx *pulumi.Context,
	name string, args *ApplicationArgs, opts ...pulumi.ResourceOption) (*Application, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Metadata == nil {
		return nil, errors.New("invalid value for required argument 'Metadata'")
	}
	if args.Spec == nil {
		return nil, errors.New("invalid value for required argument 'Spec'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Application
	err := ctx.RegisterResource("argocd:index/application:Application", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetApplication gets an existing Application resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetApplication(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ApplicationState, opts ...pulumi.ResourceOption) (*Application, error) {
	var resource Application
	err := ctx.ReadResource("argocd:index/application:Application", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Application resources.
type applicationState struct {
	// Whether to applying cascading deletion when application is removed.
	Cascade *bool `pulumi:"cascade"`
	// Standard Kubernetes object metadata. For more info see the [Kubernetes reference](https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#metadata).
	Metadata *ApplicationMetadata `pulumi:"metadata"`
	// The application specification.
	Spec *ApplicationSpec `pulumi:"spec"`
	// Status information for the application. **Note**: this is not guaranteed to be up to date immediately after
	// creating/updating an application unless `wait=true`.
	Statuses []ApplicationStatus `pulumi:"statuses"`
	// Upon application creation or update, wait for application health/sync status to be healthy/Synced, upon application
	// deletion, wait for application to be removed, when set to true. Wait timeouts are controlled by Terraform Create, Update
	// and Delete resource timeouts (all default to 5 minutes). **Note**: if ArgoCD decides not to sync an application (e.g.
	// because the project to which the application belongs has a `sync_window` applied) then you will experience an expected
	// timeout event if `wait = true`.
	Wait *bool `pulumi:"wait"`
}

type ApplicationState struct {
	// Whether to applying cascading deletion when application is removed.
	Cascade pulumi.BoolPtrInput
	// Standard Kubernetes object metadata. For more info see the [Kubernetes reference](https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#metadata).
	Metadata ApplicationMetadataPtrInput
	// The application specification.
	Spec ApplicationSpecPtrInput
	// Status information for the application. **Note**: this is not guaranteed to be up to date immediately after
	// creating/updating an application unless `wait=true`.
	Statuses ApplicationStatusArrayInput
	// Upon application creation or update, wait for application health/sync status to be healthy/Synced, upon application
	// deletion, wait for application to be removed, when set to true. Wait timeouts are controlled by Terraform Create, Update
	// and Delete resource timeouts (all default to 5 minutes). **Note**: if ArgoCD decides not to sync an application (e.g.
	// because the project to which the application belongs has a `sync_window` applied) then you will experience an expected
	// timeout event if `wait = true`.
	Wait pulumi.BoolPtrInput
}

func (ApplicationState) ElementType() reflect.Type {
	return reflect.TypeOf((*applicationState)(nil)).Elem()
}

type applicationArgs struct {
	// Whether to applying cascading deletion when application is removed.
	Cascade *bool `pulumi:"cascade"`
	// Standard Kubernetes object metadata. For more info see the [Kubernetes reference](https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#metadata).
	Metadata ApplicationMetadata `pulumi:"metadata"`
	// The application specification.
	Spec ApplicationSpec `pulumi:"spec"`
	// Upon application creation or update, wait for application health/sync status to be healthy/Synced, upon application
	// deletion, wait for application to be removed, when set to true. Wait timeouts are controlled by Terraform Create, Update
	// and Delete resource timeouts (all default to 5 minutes). **Note**: if ArgoCD decides not to sync an application (e.g.
	// because the project to which the application belongs has a `sync_window` applied) then you will experience an expected
	// timeout event if `wait = true`.
	Wait *bool `pulumi:"wait"`
}

// The set of arguments for constructing a Application resource.
type ApplicationArgs struct {
	// Whether to applying cascading deletion when application is removed.
	Cascade pulumi.BoolPtrInput
	// Standard Kubernetes object metadata. For more info see the [Kubernetes reference](https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#metadata).
	Metadata ApplicationMetadataInput
	// The application specification.
	Spec ApplicationSpecInput
	// Upon application creation or update, wait for application health/sync status to be healthy/Synced, upon application
	// deletion, wait for application to be removed, when set to true. Wait timeouts are controlled by Terraform Create, Update
	// and Delete resource timeouts (all default to 5 minutes). **Note**: if ArgoCD decides not to sync an application (e.g.
	// because the project to which the application belongs has a `sync_window` applied) then you will experience an expected
	// timeout event if `wait = true`.
	Wait pulumi.BoolPtrInput
}

func (ApplicationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*applicationArgs)(nil)).Elem()
}

type ApplicationInput interface {
	pulumi.Input

	ToApplicationOutput() ApplicationOutput
	ToApplicationOutputWithContext(ctx context.Context) ApplicationOutput
}

func (*Application) ElementType() reflect.Type {
	return reflect.TypeOf((**Application)(nil)).Elem()
}

func (i *Application) ToApplicationOutput() ApplicationOutput {
	return i.ToApplicationOutputWithContext(context.Background())
}

func (i *Application) ToApplicationOutputWithContext(ctx context.Context) ApplicationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApplicationOutput)
}

// ApplicationArrayInput is an input type that accepts ApplicationArray and ApplicationArrayOutput values.
// You can construct a concrete instance of `ApplicationArrayInput` via:
//
//	ApplicationArray{ ApplicationArgs{...} }
type ApplicationArrayInput interface {
	pulumi.Input

	ToApplicationArrayOutput() ApplicationArrayOutput
	ToApplicationArrayOutputWithContext(context.Context) ApplicationArrayOutput
}

type ApplicationArray []ApplicationInput

func (ApplicationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Application)(nil)).Elem()
}

func (i ApplicationArray) ToApplicationArrayOutput() ApplicationArrayOutput {
	return i.ToApplicationArrayOutputWithContext(context.Background())
}

func (i ApplicationArray) ToApplicationArrayOutputWithContext(ctx context.Context) ApplicationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApplicationArrayOutput)
}

// ApplicationMapInput is an input type that accepts ApplicationMap and ApplicationMapOutput values.
// You can construct a concrete instance of `ApplicationMapInput` via:
//
//	ApplicationMap{ "key": ApplicationArgs{...} }
type ApplicationMapInput interface {
	pulumi.Input

	ToApplicationMapOutput() ApplicationMapOutput
	ToApplicationMapOutputWithContext(context.Context) ApplicationMapOutput
}

type ApplicationMap map[string]ApplicationInput

func (ApplicationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Application)(nil)).Elem()
}

func (i ApplicationMap) ToApplicationMapOutput() ApplicationMapOutput {
	return i.ToApplicationMapOutputWithContext(context.Background())
}

func (i ApplicationMap) ToApplicationMapOutputWithContext(ctx context.Context) ApplicationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApplicationMapOutput)
}

type ApplicationOutput struct{ *pulumi.OutputState }

func (ApplicationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Application)(nil)).Elem()
}

func (o ApplicationOutput) ToApplicationOutput() ApplicationOutput {
	return o
}

func (o ApplicationOutput) ToApplicationOutputWithContext(ctx context.Context) ApplicationOutput {
	return o
}

// Whether to applying cascading deletion when application is removed.
func (o ApplicationOutput) Cascade() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *Application) pulumi.BoolPtrOutput { return v.Cascade }).(pulumi.BoolPtrOutput)
}

// Standard Kubernetes object metadata. For more info see the [Kubernetes reference](https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#metadata).
func (o ApplicationOutput) Metadata() ApplicationMetadataOutput {
	return o.ApplyT(func(v *Application) ApplicationMetadataOutput { return v.Metadata }).(ApplicationMetadataOutput)
}

// The application specification.
func (o ApplicationOutput) Spec() ApplicationSpecOutput {
	return o.ApplyT(func(v *Application) ApplicationSpecOutput { return v.Spec }).(ApplicationSpecOutput)
}

// Status information for the application. **Note**: this is not guaranteed to be up to date immediately after
// creating/updating an application unless `wait=true`.
func (o ApplicationOutput) Statuses() ApplicationStatusArrayOutput {
	return o.ApplyT(func(v *Application) ApplicationStatusArrayOutput { return v.Statuses }).(ApplicationStatusArrayOutput)
}

// Upon application creation or update, wait for application health/sync status to be healthy/Synced, upon application
// deletion, wait for application to be removed, when set to true. Wait timeouts are controlled by Terraform Create, Update
// and Delete resource timeouts (all default to 5 minutes). **Note**: if ArgoCD decides not to sync an application (e.g.
// because the project to which the application belongs has a `sync_window` applied) then you will experience an expected
// timeout event if `wait = true`.
func (o ApplicationOutput) Wait() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *Application) pulumi.BoolPtrOutput { return v.Wait }).(pulumi.BoolPtrOutput)
}

type ApplicationArrayOutput struct{ *pulumi.OutputState }

func (ApplicationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Application)(nil)).Elem()
}

func (o ApplicationArrayOutput) ToApplicationArrayOutput() ApplicationArrayOutput {
	return o
}

func (o ApplicationArrayOutput) ToApplicationArrayOutputWithContext(ctx context.Context) ApplicationArrayOutput {
	return o
}

func (o ApplicationArrayOutput) Index(i pulumi.IntInput) ApplicationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Application {
		return vs[0].([]*Application)[vs[1].(int)]
	}).(ApplicationOutput)
}

type ApplicationMapOutput struct{ *pulumi.OutputState }

func (ApplicationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Application)(nil)).Elem()
}

func (o ApplicationMapOutput) ToApplicationMapOutput() ApplicationMapOutput {
	return o
}

func (o ApplicationMapOutput) ToApplicationMapOutputWithContext(ctx context.Context) ApplicationMapOutput {
	return o
}

func (o ApplicationMapOutput) MapIndex(k pulumi.StringInput) ApplicationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Application {
		return vs[0].(map[string]*Application)[vs[1].(string)]
	}).(ApplicationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ApplicationInput)(nil)).Elem(), &Application{})
	pulumi.RegisterInputType(reflect.TypeOf((*ApplicationArrayInput)(nil)).Elem(), ApplicationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ApplicationMapInput)(nil)).Elem(), ApplicationMap{})
	pulumi.RegisterOutputType(ApplicationOutput{})
	pulumi.RegisterOutputType(ApplicationArrayOutput{})
	pulumi.RegisterOutputType(ApplicationMapOutput{})
}