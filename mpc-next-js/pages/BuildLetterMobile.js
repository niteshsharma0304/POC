import Main from './shared/Main';

export default function BuildLetterMobile(props) {
    props = {
        ...props,
        isMobile: true
    };
    return (
        <>
            <Main
                {...props}
            />
        </>
    );
}