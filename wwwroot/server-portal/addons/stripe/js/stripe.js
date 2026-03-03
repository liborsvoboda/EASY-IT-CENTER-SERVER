const stripe = Stripe('pk_test_51T6ttwE3V3w1wFeSR5qLjGrVAtZHrlM8c75jZjL7XUHMO12wQ5vXqrFR8tD0cO8eDglfu06mJK0GXIw46Bei46NQ00cUaGRP9W');

//TEST CARD
//4242 4242 4242 4242
//4000002500003155

initialize();

async function initialize() {
    const fetchClientSecret = async () => {
        const response = await fetch("/StripeService/CreateCheckoutSession", {
            method: "POST",
        });
        const { clientSecret } = await response.json();
        return clientSecret;
    };


    const checkout = await stripe.initEmbeddedCheckout({
        fetchClientSecret,
    });

    checkout.mount('#checkout');
}