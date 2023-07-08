<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PostDetails.aspx.cs" Inherits="WebApplication2.Pages.PostDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:FormView ID="productDetail" runat="server" ItemType="WebApplication2.Model.Post" SelectMethod="GetPost" RenderOuterTable="false">
        <ItemTemplate>
            <div class="kt-row" style="padding: 50px">
                <div class="kt-col-5">
                    <div class="kt-page-title">
                        <div class="kt-page-title__texts">
                            <div class="kt-page-title__title kt-page-title__title--responsive-sized"><%#Item.Title %></div>
                            <div class="kt-page-title__subtitle kt-page-title__subtitle--responsive-sized"><%#:CalculateTime(Item.Created_Date) %></div>

                        </div>
                        <ul class="kt-page-title__tags"></ul>

                    </div>
                    <div class="post-actions">
                        <button class="kt-button kt-button--primary post-actions__get-contact" type="button" tabindex="0">
                            <span class="kt-text-truncate no-pointer-event">اطلاعات تماس</span>
                        </button>
                    </div>
                    <div class="expandable-box expandable-box--collapsed">
                    </div>
                    <div class="post-page__section--padded">

                        <div class="kt-base-row kt-base-row--large kt-unexpandable-row">
                            <div class="kt-base-row__start kt-unexpandable-row__title-box">
                                <p class="kt-base-row__title kt-unexpandable-row__title">قیمت کل</p>

                            </div>
                            <div class="kt-base-row__end kt-unexpandable-row__value-box">
                                <p class="kt-unexpandable-row__value"><%#Item.Price %></p>

                            </div>

                        </div>

                        <hr class="kt-divider">
                        <div class="kt-base-row kt-base-row--large kt-unexpandable-row">
                            <div class="kt-base-row__start kt-unexpandable-row__title-box">
                                <p class="kt-base-row__title kt-unexpandable-row__title">آگهی‌دهنده</p>

                            </div>
                            <div class="kt-base-row__end kt-unexpandable-row__value-box">
                                <p class="kt-unexpandable-row__value">شخصی</p>

                            </div>

                        </div>
                        <hr class="kt-divider">
                        <div class="kt-base-row kt-base-row--large kt-unexpandable-row">
                            <div class="kt-base-row__start kt-unexpandable-row__title-box">
                                <p class="kt-base-row__title kt-unexpandable-row__title">وضعیت </p>

                            </div>
                            <div class="kt-base-row__end kt-unexpandable-row__value-box">
                                <p class="kt-unexpandable-row__value"><%#Item.State.StateName %></p>

                            </div>

                        </div>
                        <hr class="kt-divider">
                        <div class="kt-base-row kt-base-row--large kt-unexpandable-row">
                            <div class="kt-base-row__start kt-unexpandable-row__title-box">
                                <p class="kt-base-row__title kt-unexpandable-row__title">دسته بندی </p>

                            </div>
                            <div class="kt-base-row__end kt-unexpandable-row__value-box">
                                <p class="kt-unexpandable-row__value"><%#Item.Category.CategoryName %></p>

                            </div>

                        </div>
                        <asp:Repeater ID="Repeater1" runat="server" SelectMethod="Repeater1_GetData" ItemType="WebApplication2.Model.PostAttributes">
                            <ItemTemplate>
                                <hr class="kt-divider">
                                <div class="kt-base-row kt-base-row--large kt-unexpandable-row">
                                    <div class="kt-base-row__start kt-unexpandable-row__title-box">
                                        <p class="kt-base-row__title kt-unexpandable-row__title"><%#Item.AttrName %> </p>

                                    </div>
                                    <div class="kt-base-row__end kt-unexpandable-row__value-box">
                                        <p class="kt-unexpandable-row__value"><%#Item.AttrValue %></p>

                                    </div>

                                </div>
                            </ItemTemplate>

                        </asp:Repeater>
                        <hr class="kt-divider">
                    </div>
                    <div class="post-page__section--padded">
                        <div class="kt-section-title">
                            <div>
                                <div class="kt-section-title__title-block">
                                    <span class="kt-section-title__title" style="color: rgba(0, 0, 0, 0.87);">توضیحات</span>

                                </div>

                            </div>

                        </div>
                        <div class="kt-base-row kt-base-row--large kt-description-row">
                            <div class="kt-base-row__start">
                                <p class="kt-description-row__text kt-description-row__text--primary"><%#Item.Description %></p>

                            </div>

                        </div>

                    </div>

                </div>
                <div class="kt-col-6 kt-offset-1">
                    <div class="post-page__section--padded">
                        <div>
                            <div class="kt-carousel">
                                <div class="kt-carousel__slider-wrapper">
                                    <div class="kt-carousel__track">
                                        <ul class="kt-carousel__slides" style="transform: translateX(0px);">
                                            <li class="kt-carousel__slide" role="presentation">
                                                <div class="kt-carousel__slide-wrapper">
                                                    <div class="kt-carousel__slide-container">
                                                        <template>

                                                  </template>
                                                        <button type="button" class="kt-carousel__slide-button kt-carousel__button kt-carousel__slide-image" style="color:blue;">
                                                            <picture class="kt-image-block" style="padding-bottom: 75%;">
                                                          <source srcset="<%#:Item.Image%>" type="image/jpeg">
                                                          <img class="kt-image-block__image kt-image-block__image--fading" src="<%#:Item.Image%>" alt="">

                                                      </picture>

                                                        </button>

                                                        <div class="kt-carousel__slide-loading-overlay">
                                                        </div>

                                                    </div>

                                                </div>
                                                <span class="kt-progress-circular kt-carousel__slide-indicator kt-carousel__slide-indicator--hidden kt-progress-circular--white kt-progress-circular--animated kt-progress-circular--lg">
                                                    <svg xmlns="http://www.w3.org/2000/svg" class="kt-progress-circular__content" viewBox="0 0 16 16">
                                                        <g class="kt-progress-circular__rotate">
                                                            <path class="kt-progress-circular__static-particle" d="M8,16a8,8,0,1,1,8-8A8,8,0,0,1,8,16ZM8,2a6,6,0,1,0,6,6A6,6,0,0,0,8,2Z">
                                                            </path>
                                                            <circle class="kt-progress-circular__moving-particle" cx="8" cy="8" r="7">
                                                            </circle>

                                                        </g>

                                                    </svg>

                                                </span>

                                            </li>

                                        </ul>

                                    </div>
                                    <div>
                                        <button type="button" class="kt-carousel__control kt-carousel__button kt-carousel__control--prev kt-carousel__control--hidden">
                                            <i class="kt-icon kt-icon-keyboard-arrow-right kt-icon--lg kt-carousel__control-icon"></i>

                                        </button>
                                        <button type="button" class="kt-carousel__control kt-carousel__button kt-carousel__control--hidden">
                                            <i class="kt-icon kt-icon-keyboard-arrow-left kt-icon--lg kt-carousel__control-icon"></i>

                                        </button>

                                    </div>

                                </div>

                            </div>

                        </div>

                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:FormView>

</asp:Content>
